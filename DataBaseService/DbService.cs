using QualityReaction.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualityReaction.DataBaseService
{
    public class DbService
    {
        private static DbContextHandler _context = new DbContextHandler();

        public static IList<T> FindAll<T>()
        {
            return _context.Database.SqlQuery<T>($"select * from {typeof(T).Name}s").ToList();
        }

        public static IList<T> FindWhere<T>(string where, object value)
        {
            return _context.Database.SqlQuery<T>($"select * from {typeof(T).Name}s where {where} = '{value}'").ToList();
        }

        public static IList<T> FindWhere<T>(string[] where, string[] values)
        {
            IList<string> wheres = new List<string>();
            for (int i = 0; i < where.Count(); i++)
            {
                wheres.Add($"{where[i]} = '{values[i]}'");
            }
            return _context.Database.SqlQuery<T>($"select * from {typeof(T).Name}s where {string.Join(" AND ", wheres)}").ToList();
        }

        public static IList<T> FindIn<T>(string where, string[] values)
        {
            string inValues = string.Join("','", values);
            return _context.Database.SqlQuery<T>($"select * from {typeof(T).Name}s where {where} in ('{inValues}')").ToList();
        }

        public static int Count<T>(string where, object value)
        {
            return _context.Database.SqlQuery<int>($"select count(id) from {typeof(T).Name}s where {where} = '{value}'").First();
        }

        public static void Create<T>(T element)
        {
            if (typeof(T) == typeof(Case))
            {
                var add = element as Case;
                add.Id = Guid.NewGuid();
                _context.Cases.Add(add);
            }

            _context.SaveChanges();
        }

        public static void DeleteAll<T>() where T : class
        {
            _context.Database.ExecuteSqlCommand("delete from " + typeof(T).Name + "s");
        }

        public static void Delete<T>(string where, object value) where T : class
        {
            if (value != null)
            {
                _context.Database.ExecuteSqlCommand($"delete from {typeof(T).Name}s where {where} = '{value}'");
            }
            _context.SaveChanges();
        }
    }
}
