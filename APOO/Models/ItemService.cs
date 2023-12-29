using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static APOO.Models.ItemDAL;

namespace APOO.Models
{
    public class ItemService
    {
        private readonly ItemDal _itemDal;

        public ItemService()
        {
            _itemDal = new ItemDal();
        }

        // Método para gravar um item, que chama o método da DAL
        public void Gravar(ItemTema item)
        {
            _itemDal.Gravar(item);
        }
    }
}