﻿namespace CatalogApp.BLL.DTO
{
    public class OrderItemDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public PhoneDTO Phone { get; set; }
    }
}