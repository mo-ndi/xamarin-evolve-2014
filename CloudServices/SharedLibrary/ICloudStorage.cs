using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portable
{
	public interface ICloudStorage
	{
		Task<List<TodoItem>> RefreshDataAsync();

		Task<TodoItem> GetTodoItemAsync (string id);

		Task SaveTodoItemAsync (TodoItem item);

		Task DeleteTodoItemAsync (TodoItem id);
	}
}

