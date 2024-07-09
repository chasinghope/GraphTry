using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Linq.Expressions;

public class People
{
    public int age;
    
    public override string ToString()
    {
        return age.ToString();
    }
}

public class Boy : People
{
    
}

public class Test_Expression : MonoBehaviour
{
    void Start()
    {
        Test_3();
    }


    private void Test_3()
    {
        Debug.Log(typeof(Boy).IsAssignableFrom(typeof(People)));
        Debug.Log(typeof(People).IsAssignableFrom(typeof(Boy)));
        
    }
    
    
    private void Test_1()
    {
        List<People> peopleList = new List<People>();
        
        peopleList.Add(new People() { age = 4 });
        peopleList.Add(new People() { age = 17 });
        peopleList.Add(new People() { age = 18 });
        
        peopleList.Add(new People() { age = 20 });
        peopleList.Add(new People() { age = 25 });
        peopleList.Add(new People() { age = 30 });
        
        
        // PrintPeoples(peopleList);
        
        IQueryable<People> queryable = peopleList.AsQueryable();
        
        Expression<Func<People, bool>> expression = p => p.age > 18;
        List<People> result = queryable.Where(expression).ToList();
        
        
        PrintPeoples(result);
    }


    private void Test_2()
    {
        Func<int, int, int> func = (x1, x2) => x1 + x2;
    }


    private void PrintPeoples(List<People> peopleList)
    {
        foreach (var p in peopleList)
        {
            Debug.Log(p.ToString());
        }
    }

}