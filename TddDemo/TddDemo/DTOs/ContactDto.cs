﻿namespace TddDemo.DTOs;

public class ContactDto
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}