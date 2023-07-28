namespace firstnet.Application.Interface;
using firstnet.Domain.Model;
public interface IOrganization {
    IReadOnlyList<Organization> Get();
    Organization GetById(int id);
    string Delete(int id);

    Organization Edit(Organization organization);
    string Add(Organization organization);

}