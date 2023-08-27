using TddDemo.DTOs;

namespace TddDemo.Services;

public class ContactsService
{
    public ContactDto Create(ContactForCreationDto contactForCreationDto)
    {
        if (contactForCreationDto is null)
        {
            throw new ArgumentNullException(nameof(contactForCreationDto));
        }

        var contact = new ContactDto
        {
            Id = Guid.NewGuid(),
            FirstName = contactForCreationDto.FirstName,
            LastName = contactForCreationDto.LastName,
        };

        return contact;
    }
}