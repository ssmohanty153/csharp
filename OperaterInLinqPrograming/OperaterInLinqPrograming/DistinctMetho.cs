﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
	public class DistinctMetho
	{
		public static void Main()

		{

			IList<Student> studentList = new List<Student>() 
			{
			new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
			new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
			new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
			new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
		};


			var distinctStudents = studentList.Distinct(new StudentComparer1());

			foreach (var std in distinctStudents)
				Console.WriteLine(std.StudentName);

		}
	}

public class StudentComparer1 : IEqualityComparer<Student>
{
		
			public bool Equals(Student x, Student y)
			{
				if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
					return true;

				return false;
			}

			public int GetHashCode(Student obj)
			{
				return obj.GetHashCode();
			}
		}

	}

