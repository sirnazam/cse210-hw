
using System;
using System.Collections.Generic;

namespace Sirnazam
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalCost = 0;

            foreach (Product product in _products)
            {
                totalCost += product.GetTotalCost();
            }

            double shippingCost;

            if (_customer.LivesInUSA())
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }

            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "PACKING LABEL\n";

            foreach (Product product in _products)
            {
                packingLabel += product.GetName() + " - " +
                                product.GetProductId() + "\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            Address address = _customer.GetAddress();

            return "SHIPPING LABEL\n" +
                   _customer.GetName() + "\n" +
                   address.GetFullAddress();
        }
    }
}
