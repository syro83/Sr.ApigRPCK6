﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sr.Reminder.Core.Dal;

namespace Sr.Reminder.Core.Repositories
{
	public class ReminderRepository : RepositoryBase<Dal.Reminder>, IReminderRepository
	{
		public ReminderRepository(Dal.SrReminderContext context) : base(context)
		{
		}

		public Task<IEnumerable<Dal.Reminder>> GetAllByCatgory(int categoryId)
		{
			//ToDo: SR:SR ! not implemented
			var reminderCategory = new ReminderCategory() { };

			return Find(c => c.ReminderCategory.Contains(reminderCategory));
		}
	}
}
