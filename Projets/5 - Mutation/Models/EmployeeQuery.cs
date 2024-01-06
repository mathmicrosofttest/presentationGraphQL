using GraphQL;
using GraphQL.Types;
using System.Security.Cryptography;

namespace _5___Mutation.Models;

public class EmployeeQuery : ObjectGraphType
{
    [Obsolete]
    public EmployeeQuery(IEmployeeService employeeService)
    {
        Field<ListGraphType<EmployeeDetailsType>>(Name = "Employees", resolve: x => employeeService.GetEmployees());
        Field<ListGraphType<EmployeeDetailsType>>(Name = "Employee",
            arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
            resolve: x => employeeService.GetEmployee(x.GetArgument<int>("id")));
    }
}

public class EmployeeMutation : ObjectGraphType
{
    [Obsolete]
    public EmployeeMutation(EmployeeData data)
    {
        Field<EmployeeInputType>("createEmployee")
            .Argument<NonNullGraphType<EmployeeInputType>>("employee")
            .Resolve(context => 
            {
                var employee = context.GetArgument<Employee>("employee");
                return data.AddEmployee(employee);
            });

    }
}

public class EmployeeDetailsSchema : Schema
{
    public EmployeeDetailsSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<EmployeeQuery>();
        Mutation = serviceProvider.GetRequiredService<EmployeeMutation>();
    }
}
public class EmployeeData
{
    private List<Employee> _employees = new List<Employee>();

    public Employee AddEmployee(Employee employee)
    {
        _employees.Add(employee);
        return employee;
    }
}

public class EmployeeInputType : InputObjectGraphType
{
    public EmployeeInputType()
    {
        Name = "EmployeeInput";
        Field<NonNullGraphType<StringGraphType>>("name");
        Field<StringGraphType>("age");
    }
}