﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyModel.Exceptions
{
	public class ErrorObject
	{
		public int StatusCode { get; private set; }
		public string Message { get; private set; }
		public ErrorObject(int statusCode, string message)
		{
			StatusCode = statusCode;
			Message = message;
		}
	}
}
