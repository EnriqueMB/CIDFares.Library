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
        //public static DataTable ToDataTable<T>(this List<T> iList, List<string> columns = null)
        //{
        //    DataTable dataTable = new DataTable();
        //    PropertyDescriptorCollection propertyDescriptorCollection =
        //        TypeDescriptor.GetProperties(typeof(T));
        //    for (int i = 0; i < propertyDescriptorCollection.Count; i++)
        //    {
        //        PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
        //        Type type = propertyDescriptor.PropertyType;

        //        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
        //            type = Nullable.GetUnderlyingType(type);

        //        if (columns == null || columns.Where(x => x.Equals(propertyDescriptor.Name)).Any())
        //            dataTable.Columns.Add(propertyDescriptor.Name, type);
        //    }
        //    object[] values = new object[dataTable.Columns.Count];
        //    foreach (T iListItem in iList)
        //    {
        //        int y = 0;
        //        for (int i = 0; i < propertyDescriptorCollection.Count; i++)
        //        {
        //            if (columns == null || columns.Where(x => x.Equals(propertyDescriptorCollection[i].Name)).Any())
        //            {
        //                values[y] = propertyDescriptorCollection[i].GetValue(iListItem);
        //                y++;
        //            }
        //        }
        //        dataTable.Rows.Add(values);
        //    }
        //    return dataTable;
        //}

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


                //bool typeIsNullable = type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable));

                var aux = TypeDescriptor.GetProperties(type);

                if (columns == null || columns.Where(x => x.Equals(propertyDescriptor.Name)).Any())

                    if(type.GetFields().Any())
                    //if (propertyDescriptor.PropertyType.GetFields().Any())
                        dataTable.Columns.Add(propertyDescriptor.Name, type);
                    else
                    {
                        PropertyDescriptorCollection propertyDescriptorCollectionChild = TypeDescriptor.GetProperties(propertyDescriptor.PropertyType);
                        for (int j = 0; j < propertyDescriptorCollectionChild.Count; j++)
                        {
                            PropertyDescriptor propertyDescriptorChild = propertyDescriptorCollectionChild[j];
                            Type typeChild = propertyDescriptorChild.PropertyType;

                            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                                type = Nullable.GetUnderlyingType(type);

                            if (columns == null || columns.Where(x => x.Equals(propertyDescriptorChild.Name)).Any())
                                dataTable.Columns.Add(propertyDescriptorChild.Name, typeChild);
                        }
                    }
            }
            object[] values = new object[dataTable.Columns.Count];
            foreach (T iListItem in iList)
            {
                int y = 0;
                for (int i = 0; i < propertyDescriptorCollection.Count; i++)
                {
                    if (columns == null || columns.Where(x => x.Equals(propertyDescriptorCollection[i].Name)).Any())
                    {
                        Type type = propertyDescriptorCollection[i].PropertyType;

                        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                            type = Nullable.GetUnderlyingType(type);

                        if (type.GetFields().Any())
                        {
                            values[y] = propertyDescriptorCollection[i].GetValue(iListItem);
                            y++;
                        }
                        else
                        {
                            PropertyDescriptorCollection propertyDescriptorCollectionChild = TypeDescriptor.GetProperties(propertyDescriptorCollection[i].PropertyType);
                            for (int j = 0; j < propertyDescriptorCollectionChild.Count; j++)
                            {
                                if (columns == null || columns.Where(x => x.Equals(propertyDescriptorCollectionChild[j].Name)).Any())
                                {
                                    values[y] = propertyDescriptorCollectionChild[j].GetValue(propertyDescriptorCollection[i].GetValue(iListItem));
                                    y++;
                                }
                            }
                        }
                    }
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
    
}
