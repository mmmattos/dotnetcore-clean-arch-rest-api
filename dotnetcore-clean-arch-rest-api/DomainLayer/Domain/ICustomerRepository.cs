﻿using System;
namespace Domain;

public interface ICustomerRepository
{
    Customer GetById(int id);
    List<Customer> GetAll();
    void Add(Customer customer);
    void Update(Customer customer);
    void Delete(int id);
}
}

