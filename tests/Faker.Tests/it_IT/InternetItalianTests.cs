﻿using Faker.Tests.Common;
using NUnit.Framework;

namespace Faker.Tests.it_IT
{
	[SetUICulture("it-IT")]
	[SetCulture("it-IT")]
	[Category("Culture 'it_IT'")]
	public class InternetItalianTests
	{
		[Test]
		[Repeat(1000)]
		public void Should_Create_Free_Email()
		{
			string freeEmailsFormat = Resources.Internet.FreeMail.ToFormat();

			string email = Internet.FreeEmail();

			Assert.That(email, Does.Match(string.Format("@({0})$", freeEmailsFormat))
								 .And.Match(InternetTests.EMAIL_REGEX)
								 .And.Not.Contains("www"));
		}
	}
}
