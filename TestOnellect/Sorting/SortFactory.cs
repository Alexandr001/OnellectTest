using System.Reflection;

namespace TestOnellect.Sorting;

public static class SortFactory
{
	public static ISorting GetSorting()
	{
		Type[] types = Assembly.GetExecutingAssembly().GetTypes();
		List<ISorting> list = types.Where(t => 
				                                  t.GetInterfaces().Contains(typeof(ISorting)) &&
				                                  t.GetConstructor(Type.EmptyTypes) != null)
		                           .Select(t => Activator.CreateInstance(t) as ISorting).ToList()!;
		
		int random = new Random().Next(0, list.Count);
		return list[random];
	}
}