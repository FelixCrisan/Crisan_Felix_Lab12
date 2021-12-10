using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Crisan_Felix_12_2.Models;


namespace Crisan_Felix_12_2.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }

}
