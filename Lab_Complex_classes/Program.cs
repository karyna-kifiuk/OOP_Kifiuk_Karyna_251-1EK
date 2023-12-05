using System.Collections;

public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
    decimal CalculateDiscount(decimal discountPercent);
}
public abstract class Product : IProduct
{
    protected string name;
    protected decimal price;

    public Product(string name, decimal price)
    {
        name = name;
        price = price;
    }

    public string Name
    {
        get { return name; }
    }

    public decimal Price
    {
        get { return price; }
    }

    public int Id { get; internal set; }

    public abstract decimal CalculateCost();

    public decimal CalculateDiscount(decimal discountPercent)
    {
        throw new NotImplementedException();
    }
}
public class Book : Product
{
    protected int _pagesCount;

    public Book(string name, decimal price, int pagesCount) : base(name, price)
    {
        _pagesCount = pagesCount;
    }

    public override decimal CalculateCost()
    {
        return Price * (1 - _pagesCount / 100);
    }
}

public class Electronics : Product
{
    protected int _memorySize;

    public Electronics(string name, decimal price, int memorySize) : base(name, price)
    {
        _memorySize = memorySize;
    }

    public override decimal CalculateCost()
    {
        return Price * (1 - _memorySize / 10000);
    }
}

public class Clothing : Product
{
    protected string _size;

    public Clothing(string name, decimal price, string size) : base(name, price)
    {
        _size = size;
    }

    public override decimal CalculateCost()
    {
        return Price * (1 - _size.Length / 10);
    }
}
public class ProductCollection
{
    private List<Product> _products;

    public ProductCollection()
    {
        _products = new List<Product>();
    }

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public void Remove(Product product)
    {
        _products.Remove(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return _products.GetEnumerator();
    }
}
public abstract class AbstractProductRepository<TProduct>
{
    public abstract TProduct GetById(int id);

    public abstract void Add(TProduct product);

    public abstract void Remove(TProduct product);
}
public class ProductRepository : AbstractProductRepository<Product>
{
    private Dictionary<int, Product> _products;

    public ProductRepository()
    {
        _products = new Dictionary<int, Product>();
    }

    public override Product GetById(int id)
    {
        if (!_products.ContainsKey(id))
        {
            throw new KeyNotFoundException("Product with id " + id + " not found");
        }

        return _products[id];
    }

    public override void Add(Product product)
    {
        if (product.Name == null)
        {
            throw new ArgumentNullException("Product name cannot be null");
        }

        if (product.Price < 0)
        {
            throw new ArgumentOutOfRangeException("Product price cannot be negative");
        }

        _products.Add(product.Id, product);

    }

    public override void Remove(Product product)
    {
        throw new NotImplementedException();
    }
}


