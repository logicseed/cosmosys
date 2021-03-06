﻿/// <project> IceCreamManager </project>
/// <module> Route </module>
/// <author> Marc King </author>
/// <date_created> 2016-04-10 </date_created>

using System;
using System.Collections.Generic;
using System.Data;

namespace IceCreamManager.Model
{
    public class Route : DatabaseEntity
    {
        private RouteFactory routeFactory = RouteFactory.Reference;

        private int number;

        private List<City> routeCities = null;

        public Route()
        {
            ID = 0;
        }

        public override int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value < Requirement.MinRouteNumber) throw new RouteNumberInvalidException(Outcome.ValueTooSmall);
                if (value > Requirement.MaxRouteNumber) throw new RouteNumberInvalidException(Outcome.ValueTooLarge);
                number = value;
                IsSaved = false;
                ReplaceOnSave = true;
            }
        }

        public List<City> Cities
        {
            get
            {
                if (routeCities == null) routeCities = routeFactory.LoadCityList(ID);
                return routeCities;
            }
        }

        public void AddCity(City city)
        {
            if (Cities.Count >= Requirement.MaxRouteCities) throw new RouteCityCountException();
            Cities.Add(city);
            IsSaved = false;
            ReplaceOnSave = true;
        }

        public int LastCityAddedID()
        {
            throw new NotImplementedException();
        }

        public override bool Save()
        {
            return Factory.Route.Save(this);
        }

        public void RemoveCity(int cityID)
        {
            int indexToRemove = -1;

            for (int index = 0; index < Cities.Count; index++)
            {
                if (Cities[index].ID == cityID) indexToRemove = index;
            }

            Cities.RemoveAt(indexToRemove);
            IsSaved = false;
            ReplaceOnSave = true;
        }
    }
}
