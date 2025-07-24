using Implem.IRds;

namespace PleasanterContextMock.PleasanterContextMock.Libraries.Requests
{
    public class MockContext : 
        Implem.Pleasanter.Libraries.Requests.Context
        , ISqlObjectFactory
    {
        public new ISqls Sqls => throw new NotImplementedException();

        public new ISqlCommandText SqlCommandText => throw new NotImplementedException();

        public new ISqlResult SqlResult => throw new NotImplementedException();

        public new ISqlErrors SqlErrors => throw new NotImplementedException();

        public new ISqlDataType SqlDataType => throw new NotImplementedException();

        public new ISqlDefinitionSetting SqlDefinitionSetting => throw new NotImplementedException();

        public new ISqlCommand CreateSqlCommand()
        {
            throw new NotImplementedException();
        }

        public new ISqlConnection CreateSqlConnection(string connectionString)
        {
            throw new NotImplementedException();
        }

        public new ISqlConnectionStringBuilder CreateSqlConnectionStringBuilder(string connectionString)
        {
            throw new NotImplementedException();
        }

        public new ISqlDataAdapter CreateSqlDataAdapter(ISqlCommand sqlCommand)
        {
            throw new NotImplementedException();
        }

        public new ISqlParameter CreateSqlParameter()
        {
            throw new NotImplementedException();
        }

        public new ISqlParameter CreateSqlParameter(string name, object value)
        {
            throw new NotImplementedException();
        }
    }
}
