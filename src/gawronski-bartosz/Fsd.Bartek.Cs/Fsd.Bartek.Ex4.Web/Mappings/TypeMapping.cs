namespace Fsd.Bartek.Ex4.Web.Mappings
{
    public class TypeMapping
    {
        public static int ToProductTypeMapping(System.Web.Mvc.SelectListItem entity)
        {
            return int.Parse(entity.Value);
        }
    }
}