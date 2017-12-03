using Fsd.Arek.Cs.Ex4.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fsd.Arek.Cs.Ex4.Web.Models
{
    public class AdvertListToModelConverter
    {
        public static AdvertListModel Convert(IEnumerable<Advert> advertModel)
        {
            AdvertListModel advertListModel = new AdvertListModel
            {
                Adverts = advertModel.Select(x => new AdvertModel
                {
                    Name = x.name
                })
            };
            return advertListModel;
        }
    }
}