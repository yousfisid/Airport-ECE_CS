using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using JDSY.MyAirport.EF;

namespace JDSY.MyAirportGraphQL
{
    public class MyAirportQuery: ObjectGraphType
    {
        public MyAirportQuery(MyAirportContext db)
        {
            Field<ListGraphType<BagageType>>(
                "bagages",
                resolve: context => db.Bagages.ToList());
        }
    }
}
