using MVCProject.Models;

namespace MVCProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Context context;

        //public Guid Id { get; set; }
        public ProductRepository(Context context)
        {
            this.context = context;
            //Id = Guid.NewGuid();
        }

        //CRUD operations

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return context.Products.FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Update(int id, Product product)
        {
            Product pro = GetById(id);
            pro.Name = product.Name;
            pro.Image = product.Image;
            pro.Description = product.Description;
            pro.Price = product.Price;
            pro.Quantity = product.Quantity;
            pro.SubCatId = product.SubCatId;
            pro.CartId = product.CartId;
            pro.SupplierId = product.SupplierId;
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Product product = GetById(id);
            context.Products.Remove(product);
            context.SaveChanges();
        }
    }
}
