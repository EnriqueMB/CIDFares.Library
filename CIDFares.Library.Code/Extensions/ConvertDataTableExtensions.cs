using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDFares.Library.Code.Extensions
{
    public static class ConvertDataTableExtensions
    {
        public static DataTable ToDataTable<T>(this List<T> iList, List<string> columns = null)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);

                if (columns == null || columns.Where(x => x.Contains(propertyDescriptor.Name)).Any())
                    dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[dataTable.Columns.Count];
            foreach (T iListItem in iList)
            {
                int y = 0;
                for (int i = 0; i < propertyDescriptorCollection.Count; i++)
                {
                    if (columns == null || columns.Where(x => x.Contains(propertyDescriptorCollection[i].Name)).Any())
                    {
                        values[y] = propertyDescriptorCollection[i].GetValue(iListItem);
                        y++;
                    }
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
