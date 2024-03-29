﻿using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Domain.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataEFCore.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly BlazorContext _context;

        public EmployeeRepository(BlazorContext context)
        {
            _context = context;
        }

        private async Task<bool> EmployeeExists(int id, CancellationToken ct = default) =>
            await _context.Employee.AnyAsync(e => e.EmployeeId == id, ct);

        public void Dispose() => _context.Dispose();

        public async Task<List<Employee>> GetAllAsync(CancellationToken ct = default) 
            => await _context.GetAllEmployeesAsync();

        public async Task<Employee> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var employee = await _context.GetEmployeeAsync(id);
            return employee.First();
        }

        public async Task<Employee> AddAsync(Employee newEmployee, CancellationToken ct = default)
        {
            _context.Employee.Add(newEmployee);
            await _context.SaveChangesAsync(ct);
            return newEmployee;
        }

        public async Task<bool> UpdateAsync(Employee employee, CancellationToken ct = default)
        {
            if (!await EmployeeExists(employee.EmployeeId, ct))
                return false;
            _context.Employee.Update(employee);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<bool> DeleteAsync(int id, CancellationToken ct = default)
        {
            if (!await EmployeeExists(id, ct))
                return false;
            var toRemove = _context.Employee.Find(id);
            _context.Employee.Remove(toRemove);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<Employee> GetReportsToAsync(int id, CancellationToken ct = default)
        {
            var employee = await _context.GetEmployeeGetReportsToAsync(id);
            return employee.First();
        }

        public async Task<List<Employee>> GetDirectReportsAsync(int id,
            CancellationToken ct = default) => await _context.GetEmployeeDirectReportsAsync(id);
    }
}