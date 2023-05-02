using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService: IGenericService<Blog>
	{
		List<Blog> GetBlogListWithCategory();
		//Kategriye göre listeleme işlemi

		List<Blog> GetBlogListByWriter(int id);
		//Dışardan aldığın parametre ile yazarla getir
	}
}
