using System.Collections.Generic;

namespace Book_shop2.Models
{
    public interface IRepository
    {
        IList<order> GetAll();
        order Get(int id);
        void Create(order o);
    }
}