﻿using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;
namespace InvoiceManagementSystem.Repositories
{
    public class CartRepository : ICart
    {
        //method to add items to cart
        public void AddtoCart(string customerId, string productId, int quantity)
        {
            //if the product is already in the cart than incrementing the quantity value
            foreach (Models.Cart cartItem in EntityCollection.Cart)
            {
                if (cartItem.Product.ProductID == productId && cartItem.CustomerID == customerId)
                {
                    cartItem.Quantity = cartItem.Quantity + quantity;
                    return;
                }
            }
            //retrieving the product object and creating the cart object
            foreach (Models.Product product in EntityCollection.ProductList)
            {
                if (product.ProductID == productId)
                {
                    Models.Cart newCartItem = new Models.Cart(customerId, product, quantity);
                    EntityCollection.Cart.Add(newCartItem);
                }
            }
        }

        //deleting the all the cart items of user
        public void ClearCartItemsOfUser(string customerId)
        {
            EntityCollection.Cart.RemoveAll(x => x.CustomerID == customerId);
        }

        //deleting a sinlgle cart item of user
        public void DeleteCartItem(string cartId)
        {
            EntityCollection.Cart.RemoveAll(x => x.CartID == cartId);
        }


        //displaying the cart items of a user
        public List<Models.Cart> DisplayCartItemsOfUser(string customerId)
        {
            List<Models.Cart> cartItemList = new List<Models.Cart>();
            foreach (Models.Cart cartItem in EntityCollection.Cart)
            {
                if (cartItem.CustomerID == customerId)
                {
                    cartItemList.Add(cartItem);
                }
            }
            return cartItemList;
        }

        //displaying all the items present in the cart list
        public List<Models.Cart> DisplayAllCartItems()
        {
            return EntityCollection.Cart;
        }

        //method to edit the cart item
        public void EditCartItem(string cartId, int newQuantity)
        {
            foreach (Models.Cart item in EntityCollection.Cart)
            {
                if (item.CartID == cartId)
                {
                    item.Quantity = newQuantity;
                }
            }
        }


    }
}