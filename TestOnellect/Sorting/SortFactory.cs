using System.Reflection;
using BindingFlags = System.Reflection.BindingFlags;

namespace TestOnellect.Sorting;

public class SortFactory
{
	public static ISorting FactoryMethod()
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