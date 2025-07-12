namespace ResturauntViewing.Models.Models
{
    public static class ListHelperClass
    {

        public static List<int> ReturnInList(IFormCollection fs, IFormCollection? fs2)
        {
            var list = new List<int>();
            for (int i = 0; i < fs.Count(); i++)
            {
                // https://www.c-sharpcorner.com/UploadFile/618722/retrieving-data-through-form-collection-and-inserting-in-asp/
                list.Add(Convert.ToInt16(fs["#n" + i]));
            }
            return list;
        }
    }
}
