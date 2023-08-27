using TddDemo.DTOs;
using TddDemo.Services;

namespace TddDemo.Tests;

public class ContactsServiceTests
{
    private readonly ContactsService _contactsService;

    public ContactsServiceTests()
    {
        _contactsService = new ContactsService();
    }

    [Fact]
    public void Create_WhenCreated_ShouldReturnCreatedContact()
    {
        // Arrange
        var contactForCreationDto = new ContactForCreationDto
        {
            FirstName = "John",
            LastName = "Doe",
        };

        // Act
        ContactDto contact = _contactsService.Create(contactForCreationDto);

        // Assert
        Assert.NotNull(contact);
        Assert.NotEqual(Guid.Empty, contact.Id);
        Assert.Equal(contactForCreationDto.FirstName, contact.FirstName);
        Assert.Equal(contactForCreationDto.LastName, contact.LastName);
    }

    [Fact]
    public void Create_WhenContactForCreationDtoIsNull_ShouldThrowArgumentNullException()
    {
        // Arrange
        // Act
        var exception = Assert.Throws<ArgumentNullException>(() => _contactsService.Create(null!));

        // Assert
        Assert.Equal("contactForCreationDto", exception.ParamName);
    }
}