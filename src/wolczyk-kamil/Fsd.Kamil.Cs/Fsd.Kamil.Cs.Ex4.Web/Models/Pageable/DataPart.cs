using System;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Kamil.Cs.Ex4.Web.Models.Pageable
{
    public class DataPart<TItem>
    {
        public IEnumerable<TItem> Items { get; set; }

        public int TotalCount { get; set; }

        public int Take { get; set; }

        public int Skip { get; set; }
        
        public static DataPart<TItem> GetPartFromEntities<TEntity>(IEnumerable<TEntity> entities, int skip, int take, Func<TEntity, TItem> mapping)
        {
            int count = entities.Count();

            return new DataPart<TItem>
            {
                TotalCount = count,
                Take = take,
                Skip = skip,
                Items = entities.Skip(skip).Take(take).Select(entity => mapping(entity))
            };
        }
    }
}