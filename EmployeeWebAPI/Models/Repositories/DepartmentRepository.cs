﻿using EmployeeWebAPI.Data;
namespace EmployeeWebAPI.Models.Repositories
{
	public class DepartmentRepository : IDepartmentRepository{ 
		private readonly AppDbContext appDbContext;
		public DepartmentRepository(AppDbContext appDbContext) {
			this.appDbContext = appDbContext;
		}
		public Department GetDepartment(int departmentId)
		{
			return appDbContext.Departments.FirstOrDefault(d => d.DepartmentID == departmentId);
		}
		public IEnumerable<Department> GetDepartments()
		{
			return appDbContext.Departments;
		}
	}
}
