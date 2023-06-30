namespace LindaDemo.Invoices.Queries;

public static class InvoiceQueriesMssql
{
    public static string GetInvoiceQuery()
    {
        return new GetInvoiceQuery().GetQuery();
    }

    public static string DeleteInvoiceQuery()
    {
        return new DeleteInvoiceQuery().GetQuery();
    }
}