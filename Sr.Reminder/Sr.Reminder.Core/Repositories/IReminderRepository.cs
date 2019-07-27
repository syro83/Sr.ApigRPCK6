﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sr.Reminder.Core.Repositories
{
	public interface IReminderRepository : IRepositoryBase<Dal.Reminder>
	{
		Task<IEnumerable<Dal.Reminder>> GetAllByCatgory(int categoryId);
	}
}
