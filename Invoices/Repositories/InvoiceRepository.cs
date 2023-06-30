using LindaDemo.Invoices.Queries;

namespace LindaDemo.Invoices.Repositories;

public class InvoiceRepository
{
    public object GetInvoice()
    {
        var query = InvoiceQueriesMssql.GetInvoiceQuery();
        return null;
    }

    public object DeleteInvoice()
    {
        var query = InvoiceQueriesMssql.DeleteInvoiceQuery();
        return null;
    }
}