using Qualified.Data;
using System;
using System.Runtime.Serialization;

namespace Qualified.Exceptions
{
	[Serializable]
	public class QualifiedException : Exception
	{
		public QualifiedException()
		{
		}

		public QualifiedException(Error error, string code) : base($"{code}: {error.Reason}")
		{
		}

		public QualifiedException(string message) : base(message)
		{
		}

		public QualifiedException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected QualifiedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}