//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using System.ComponentModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_BD : Form
    {

        public Form_BD()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Load += FormularioEsquemas_Load;
        }


        // Evento Load del formulario
        private void FormularioEsquemas_Load(object sender, EventArgs e)
        {
            ObtenerEsquemas();
        }

        // Método para obtener los esquemas de la base de datos MySQL
        private void ObtenerEsquemas()
        {
            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = textBox_RecibeBD.Text;
            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    DataTable schemas = connection.GetSchema("Databases");

                    // Mostrar los esquemas en el ListBox
                    listBoxEsquemas.DataSource = schemas;
                    listBoxEsquemas.DisplayMember = "SCHEMA_NAME";
                    listBoxEsquemas.ValueMember = "SCHEMA_NAME";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al obtener los esquemas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos SQL (*.sql)|*.sql";
            saveFileDialog.Title = "Guardar archivo SQL";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Guardar el contenido en el archivo SQL
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(textBox_Query.Text);
                    }

                    MessageBox.Show("Archivo guardado exitosamente.", "Guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SQL (*.sql)|*.sql";
            openFileDialog.Title = "Cargar archivo SQL";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer el contenido del archivo SQL
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string contenido = reader.ReadToEnd();
                        textBox_Query.Text = contenido;
                    }

                    MessageBox.Show("Archivo cargado exitosamente.", "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            string sqlQuery = textBox_Query.Text;
            DataTable dataTable = new DataTable();
            List<string> mensajes = new List<string>();
            // Eliminar el contenido previo del DataGridView
            dataGridView1.ClearSelection();

            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = textBox_RecibeBD.Text;

            // Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            // Try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open(); // Abre la conexión

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        if (!sqlQuery.ToUpper().Contains("CREATE") && !sqlQuery.ToUpper().Contains("INSERT")
                            && !sqlQuery.ToUpper().Contains("UPDATE") && !sqlQuery.ToUpper().Contains("DELETE"))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                dataTable.Load(reader); // Crear un DataTable para almacenar los datos de la consulta
                                dataGridView1.DataSource = dataTable; // Enlazar los datos al DataGridView
                            }

                            // Verificar que el DataTable contenga los datos esperados
                            if (dataTable.Rows.Count > 0)
                            {
                                // Enlazar los datos al DataGridView
                                dataGridView1.DataSource = dataTable;
                            }
                            else
                            {
                                // No se encontraron datos, mostrar un mensaje de error
                                MessageBox.Show("Error al mostrar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Obtener los estados del SQL y mostrarlos en el TextBox
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string estado = reader[i].ToString();
                                    textBox_Consola.AppendText(estado + Environment.NewLine);
                                }
                            }
                        }
                    }
                }
                if (mensajes.Count > 0)
                {
                    string mensajeCompleto = string.Join("\n", mensajes);
                    MessageBox.Show(mensajeCompleto, "Mensajes de Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Mostrar MessageBox "EjecucionCompleta"
                MessageBox.Show("Ejecución Completa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); // Cierra la conexión a MySQL
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox3.SelectedItem.ToString();

            string generatedText = string.Empty;

            // Lógica para generar el texto según el elemento seleccionado
            switch (selectedItem)
            {
                case "Jump to":
                    generatedText = "";
                    break;
                case "SELECT":
                    generatedText = "SELECT Syntax:\r\nSELECT is used to retrieve rows selected from one or more tables, and can include UNION statements and subqueries. See union, and subqueries. A SELECT statement can start with a WITH clause to define common table expressions accessible within the SELECT. See with.\r\n\r\nThe most commonly used clauses of SELECT statements are these:\r\n\r\nEach select_expr indicates a column that you want to retrieve. There must be at least one select_expr.\r\n\r\n\r\ntable_references indicates the table or tables from which to retrieve rows. Its syntax is described in join.\r\n\r\n\r\nSELECT supports explicit partition selection using the PARTITION with a list of partitions or subpartitions (or both) following the name of the table in a table_reference (see join). In this case, rows are selected only from the partitions listed, and any other partitions of the table are ignored.";
                    break;
                case "UPDATE":
                    generatedText = "UPDATE Syntax:\r\nFor the single-table syntax, the UPDATE statement updates columns of existing rows in the named table with new values. The SET clause indicates which columns to modify and the values they should be given. Each value can be given as an expression, or the keyword DEFAULT to set a column explicitly to its default value. The WHERE clause, if given, specifies the conditions that identify which rows to update. With no WHERE clause, all rows are updated. If the ORDER BY clause is specified, the rows are updated in the order that is specified. The LIMIT clause places a limit on the number of rows that can be updated.\r\n\r\nFor the multiple-table syntax, UPDATE updates rows in each table named in table_references that satisfy the conditions. Each matching row is updated once, even if it matches the conditions multiple times. For multiple-table syntax, ORDER BY and LIMIT cannot be used.\r\n\r\nFor partitioned tables, both the single-single and multiple-table forms of this statement support the use of a PARTITION option as part of a table reference. This option takes a list of one or more partitions or subpartitions (or both). Only the partitions (or subpartitions) listed are checked for matches, and a row that is not in any of these partitions or subpartitions is not updated, whether it satisfies the where_condition or not.\r\n\r\nFor more information and examples, see partitioning-selection.\r\n\r\nwhere_condition is an expression that evaluates to true for each row to be updated. For expression syntax, see expressions.\r\n\r\ntable_references and where_condition are specified as described in select.\r\n\r\nYou need the UPDATE privilege only for columns referenced in an UPDATE that are actually updated. You need only the SELECT privilege for any columns that are read but not modified.\r\n\r\nThe UPDATE statement supports the following modifiers:\r\n\r\nWith the LOW_PRIORITY modifier, execution of the UPDATE is delayed until no other clients are reading from the table. This affects only storage engines that use only table-level locking (such as MyISAM, MEMORY, and MERGE).\r\n\r\n\r\nWith the IGNORE modifier, the update statement does not abort even if errors occur during the update. Rows for which duplicate-key conflicts occur on a unique key value are not updated. Rows updated to values that would cause data conversion errors are updated to the closest valid values instead. For more information, see ignore-strict-comparison.\r\n\r\n\r\n\r\nSee also: : Online help update";
                    break;
                case "INSERT":
                    generatedText = "INSERT Syntax:\r\nINSERT inserts new rows into an existing table. The INSERT ... VALUES and INSERT ... SET forms of the statement insert rows based on explicitly specified values. The INSERT ... SELECT form inserts rows selected from another table or tables. INSERT with an ON DUPLICATE KEY UPDATE clause enables existing rows to be updated if a row to be inserted would cause a duplicate value in a UNIQUE index or PRIMARY KEY.\r\n\r\nFor additional information about INSERT ... SELECT and INSERT ... ON DUPLICATE KEY UPDATE, see insert-select, and insert-on-duplicate.\r\n\r\nIn MySQL current-series, the DELAYED keyword is accepted but ignored by the server. For the reasons for this, see insert-delayed,\r\n\r\nInserting into a table requires the INSERT privilege for the table. If the ON DUPLICATE KEY UPDATE clause is used and a duplicate key causes an UPDATE to be performed instead, the statement requires the UPDATE privilege for the columns to be updated. For columns that are read but not modified you need only the SELECT privilege (such as for a column referenced only on the right hand side of an col_name=expr assignment in an ON DUPLICATE KEY UPDATE clause).\r\n\r\nWhen inserting into a partitioned table, you can control which partitions and subpartitions accept new rows. The PARTITION option takes a list of the comma-separated names of one or more partitions or subpartitions (or both) of the table. If any of the rows to be inserted by a given INSERT statement do not match one of the partitions listed, the INSERT statement fails with the error Found a row not matching the given partition set. For more information and examples, see partitioning-selection.\r\n\r\nSee also: : Online help insert";
                    break;
                case "DELETE":
                    generatedText = "DELETE Syntax:\r\nYou need the DELETE privilege on a table to delete rows from it. You need only the SELECT privilege for any columns that are only read, such as those named in the WHERE clause.\r\n\r\nWhen you do not need to know the number of deleted rows, the TRUNCATE TABLE statement is a faster way to empty a table than a DELETE statement with no WHERE clause. Unlike DELETE, TRUNCATE TABLE cannot be used within a transaction or if you have a lock on the table. See truncate-table and lock-tables.\r\n\r\nThe speed of delete operations may also be affected by factors discussed in delete-optimization.\r\n\r\nTo ensure that a given DELETE statement does not take too much time, the MySQL-specific LIMIT row_count clause for DELETE specifies the maximum number of rows to be deleted. If the number of rows to delete is larger than the limit, repeat the DELETE statement until the number of affected rows is less than the LIMIT value.\r\n\r\nYou cannot delete from a table and select from the same table in a subquery.\r\n\r\nDELETE supports explicit partition selection using the PARTITION option, which takes a list of the comma-separated names of one or more partitions or subpartitions (or both) from which to select rows to be dropped. Partitions not included in the list are ignored. Given a partitioned table t with a partition named p0, executing the statement DELETE FROM t PARTITION (p0) has the same effect on the table as executing ALTER TABLE t TRUNCATE PARTITION (p0); in both cases, all rows in partition p0 are dropped.\r\n\r\nPARTITION can be used along with a WHERE condition, in which case the condition is tested only on rows in the listed partitions. For example, DELETE FROM t PARTITION (p0) WHERE c < 5 deletes rows only from partition p0 for which the condition c < 5 is true; rows in any other partitions are not checked and thus not affected by the DELETE.\r\n\r\nThe PARTITION option can also be used in multiple-table DELETE statements. You can use up to one such option per table named in the FROM option.\r\n\r\nFor more information and examples, see partitioning-selection.\r\n\r\nSee also: : Online help delete";
                    break;
                case "CREATE TABLE":
                    generatedText = "CREATE TABLE Syntax:\r\nCREATE TABLE creates a table with the given name. You must have the CREATE privilege for the table.\r\n\r\nBy default, tables are created in the default database, using the InnoDB storage engine. An error occurs if the table exists, if there is no default database, or if the database does not exist.\r\n\r\nMySQL has no limit on the number of tables. The underlying file system may have a limit on the number of files that represent tables. Individual storage engines may impose engine-specific constraints. InnoDB permits up to 4 billion tables.\r\n\r\nFor information about the physical representation of a table, see create-table-files.\r\n\r\nSee also: : Online help create-table";
                    break;
                case "CREATE VIEW":
                    generatedText = "CREATE VIEW Syntax:\r\nThe CREATE VIEW statement creates a new view, or replaces an existing view if the OR REPLACE clause is given. If the view does not exist, CREATE OR REPLACE VIEW is the same as CREATE VIEW. If the view does exist, CREATE OR REPLACE VIEW replaces it.\r\n\r\nFor information about restrictions on view use, see view-restrictions.\r\n\r\nThe select_statement is a SELECT statement that provides the definition of the view. (Selecting from the view selects, in effect, using the SELECT statement.) The select_statement can select from base tables or other views.\r\n\r\nThe view definition is frozen at creation time and is not affected by subsequent changes to the definitions of the underlying tables. For example, if a view is defined as SELECT * on a table, new columns added to the table later do not become part of the view, and columns dropped from the table will result in an error when selecting from the view.\r\n\r\nThe ALGORITHM clause affects how MySQL processes the view. The DEFINER and SQL SECURITY clauses specify the security context to be used when checking access privileges at view invocation time. The WITH CHECK OPTION clause can be given to constrain inserts or updates to rows in tables referenced by the view. These clauses are described later in this section.\r\n\r\nThe CREATE VIEW statement requires the CREATE VIEW privilege for the view, and some privilege for each column selected by the SELECT statement. For columns used elsewhere in the SELECT statement, you must have the SELECT privilege. If the OR REPLACE clause is present, you must also have the DROP privilege for the view. If the DEFINER clause is present, the privileges required depend on the user value, as discussed in stored-objects-security.\r\n\r\nWhen a view is referenced, privilege checking occurs as described later in this section.\r\n\r\nA view belongs to a database. By default, a new view is created in the default database. To create the view explicitly in a given database, use db_name.view_name syntax to qualify the view name with the database name:\r\n\r\n>\r\nCREATE VIEW test.v AS SELECT * FROM t;\r\nUnqualified table or view names in the SELECT statement are also interpreted with respect to the default database. A view can refer to tables or views in other databases by qualifying the table or view name with the appropriate database name.\r\n\r\nWithin a database, base tables and views share the same namespace, so a base table and a view cannot have the same name.\r\n\r\nColumns retrieved by the SELECT statement can be simple references to table columns, or expressions that use functions, constant values, operators, and so forth.\r\n\r\nA view must have unique column names with no duplicates, just like a base table. By default, the names of the columns retrieved by the SELECT statement are used for the view column names. To define explicit names for the view columns, specify the optional column_list clause as a list of comma-separated identifiers. The number of names in column_list must be the same as the number of columns retrieved by the SELECT statement.\r\n\r\nA view can be created from many kinds of SELECT statements. It can refer to base tables or other views. It can use joins, UNION, and subqueries. The SELECT need not even refer to any tables:\r\n\r\n>\r\nCREATE VIEW v_today (today) AS SELECT CURRENT_DATE;\r\nThe following example defines a view that selects two columns from another table as well as an expression calculated from those columns:\r\n\r\n>\r\nmysql> CREATE TABLE t (qty INT, price INT);\r\nmysql> INSERT INTO t VALUES(3, 50);\r\nmysql> CREATE VIEW v AS SELECT qty, price, qty*price AS value FROM t;\r\nmysql> SELECT * FROM v;\r\n+------+-------+-------+\r\n| qty  | price | value |\r\n+------+-------+-------+\r\n|    3 |    50 |   150 |\r\n+------+-------+-------+\r\nA view definition is subject to the following restrictions:\r\n\r\nThe SELECT statement cannot refer to system variables or user-defined variables.\r\n\r\n\r\nWithin a stored program, the SELECT statement cannot refer to program parameters or local variables.\r\n\r\n\r\nThe SELECT statement cannot refer to prepared statement parameters.\r\n\r\n\r\nAny table or view referred to in the definition must exist. If, after the view has been created, a table or view that the definition refers to is dropped, use of the view results in an error. To check a view definition for problems of this kind, use the CHECK TABLE statement.\r\n\r\n\r\nThe definition cannot refer to a TEMPORARY table, and you cannot create a TEMPORARY view.\r\n\r\n\r\nYou cannot associate a trigger with a view.\r\n\r\n\r\nAliases for column names in the SELECT statement are checked against the maximum column length of 64 characters (not the maximum alias length of 256 characters).\r\n\r\n\r\n\r\nORDER BY is permitted in a view definition, but it is ignored if you select from a view using a statement that has its own ORDER BY.\r\n\r\nFor other options or clauses in the definition, they are added to the options or clauses of the statement that references the view, but the effect is undefined. For example, if a view definition includes a LIMIT clause, and you select from the view using a statement that has its own LIMIT clause, it is undefined which limit applies. This same principle applies to options such as ALL, DISTINCT, or SQL_SMALL_RESULT that follow the SELECT keyword, and to clauses such as INTO, FOR UPDATE, FOR SHARE, LOCK IN SHARE MODE, and PROCEDURE.\r\n\r\nThe results obtained from a view may be affected if you change the query processing environment by changing system variables:\r\n\r\n>\r\n\r\nmysql> CREATE VIEW v (mycol) AS SELECT 'abc';\r\nQuery OK, 0 rows affected (0.01 sec)\r\n\r\nmysql> SET sql_mode = '';\r\nQuery OK, 0 rows affected (0.00 sec)\r\n\r\nmysql> SELECT \"mycol\" FROM v;\r\n+-------+\r\n| mycol |\r\n+-------+\r\n| mycol |\r\n+-------+\r\n1 row in set (0.01 sec)\r\n\r\nmysql> SET sql_mode = 'ANSI_QUOTES';\r\nQuery OK, 0 rows affected (0.00 sec)\r\n\r\nmysql> SELECT \"mycol\" FROM v;\r\n+-------+\r\n| mycol |\r\n+-------+\r\n| abc   |\r\n+-------+\r\n1 row in set (0.00 sec)\r\nThe DEFINER and SQL SECURITY clauses determine which MySQL account to use when checking access privileges for the view when a statement is executed that references the view. The valid SQL SECURITY characteristic values are DEFINER (the default) and INVOKER. These indicate that the required privileges must be held by the user who defined or invoked the view, respectively.\r\n\r\nIf the DEFINER clause is present, the user value should be a MySQL account specified as 'user_name'@'host_name', CURRENT_USER, or CURRENT_USER(). The permitted user values depend on the privileges you hold, as discussed in stored-objects-security. Also see that section for additional information about view security.\r\n\r\nIf the DEFINER clause is omitted, the default definer is the user who executes the CREATE VIEW statement. This is the same as specifying DEFINER = CURRENT_USER explicitly.\r\n\r\nWithin a view definition, the CURRENT_USER function returns the view's DEFINER value by default. For views defined with the SQL SECURITY INVOKER characteristic, CURRENT_USER returns the account for the view's invoker. For information about user auditing within views, see account-activity-auditing.\r\n\r\nWithin a stored routine that is defined with the SQL SECURITY DEFINER characteristic, CURRENT_USER returns the routine's DEFINER value. This also affects a view defined within such a routine, if the view definition contains a DEFINER value of CURRENT_USER.\r\n\r\nMySQL checks view privileges like this:\r\n\r\nAt view definition time, the view creator must have the privileges needed to use the top-level objects accessed by the view. For example, if the view definition refers to table columns, the creator must have some privilege for each column in the select list of the definition, and the SELECT privilege for each column used elsewhere in the definition. If the definition refers to a stored function, only the privileges needed to invoke the function can be checked. The privileges required at function invocation time can be checked only as it executes: For different invocations, different execution paths within the function might be taken.\r\n\r\n\r\nThe user who references a view must have appropriate privileges to access it (SELECT to select from it, INSERT to insert into it, and so forth.)\r\n\r\n\r\nWhen a view has been referenced, privileges for objects accessed by the view are checked against the privileges held by the view DEFINER account or invoker, depending on whether the SQL SECURITY characteristic is DEFINER or INVOKER, respectively.\r\n\r\n\r\nIf reference to a view causes execution of a stored function, privilege checking for statements executed within the function depend on whether the function SQL SECURITY characteristic is DEFINER or INVOKER. If the security characteristic is DEFINER, the function runs with the privileges of the DEFINER account. If the characteristic is INVOKER, the function runs with the privileges determined by the view's SQL SECURITY characteristic.\r\n\r\n\r\n\r\nExample: A view might depend on a stored function, and that function might invoke other stored routines. For example, the following view invokes a stored function f():\r\n\r\n>\r\nCREATE VIEW v AS SELECT * FROM t WHERE t.id = f(t.name);\r\nSuppose that f() contains a statement such as this:\r\n\r\n>\r\nIF name IS NULL then\r\n  CALL p1();\r\nELSE\r\n  CALL p2();\r\nEND IF;\r\nThe privileges required for executing statements within f() need to be checked when f() executes. This might mean that privileges are needed for p1() or p2(), depending on the execution path within f(). Those privileges must be checked at runtime, and the user who must possess the privileges is determined by the SQL SECURITY values of the view v and the function f().\r\n\r\nThe DEFINER and SQL SECURITY clauses for views are extensions to standard SQL. In standard SQL, views are handled using the rules for SQL SECURITY DEFINER. The standard says that the definer of the view, which is the same as the owner of the view's schema, gets applicable privileges on the view (for example, SELECT) and may grant them. MySQL has no concept of a schema owner, so MySQL adds a clause to identify the definer. The DEFINER clause is an extension where the intent is to have what the standard has; that is, a permanent record of who defined the view. This is why the default DEFINER value is the account of the view creator.\r\n\r\nThe optional ALGORITHM clause is a MySQL extension to standard SQL. It affects how MySQL processes the view. ALGORITHM takes three values: MERGE, TEMPTABLE, or UNDEFINED. For more information, see view-algorithms, as well as derived-table-optimization.\r\n\r\nSome views are updatable. That is, you can use them in statements such as UPDATE, DELETE, or INSERT to update the contents of the underlying table. For a view to be updatable, there must be a one-to-one relationship between the rows in the view and the rows in the underlying table. There are also certain other constructs that make a view nonupdatable.\r\n\r\nA generated column in a view is considered updatable because it is possible to assign to it. However, if such a column is updated explicitly, the only permitted value is DEFAULT. For information about generated columns, see create-table-generated-columns.\r\n\r\nThe WITH CHECK OPTION clause can be given for an updatable view to prevent inserts or updates to rows except those for which the WHERE clause in the select_statement is true.\r\n\r\nIn a WITH CHECK OPTION clause for an updatable view, the LOCAL and CASCADED keywords determine the scope of check testing when the view is defined in terms of another view. The LOCAL keyword restricts the CHECK OPTION only to the view being defined. CASCADED causes the checks for underlying views to be evaluated as well. When neither keyword is given, the default is CASCADED.\r\n\r\nFor more information about updatable views and the WITH CHECK OPTION clause, see view-updatability, and view-check-option.\r\n\r\nSee also: : Online help create-view";
                    break;
                case "CREATE PROCEDURE":
                    generatedText = "CREATE PROCEDURE Syntax:\r\nThese statements create stored routines. By default, a routine is associated with the default database. To associate the routine explicitly with a given database, specify the name as db_name.sp_name when you create it.\r\n\r\nThe CREATE FUNCTION statement is also used in MySQL to support UDFs (user-defined functions). See adding-functions. A UDF can be regarded as an external stored function. Stored functions share their namespace with UDFs. See function-resolution, for the rules describing how the server interprets references to different kinds of functions.\r\n\r\nTo invoke a stored procedure, use the CALL statement (see call). To invoke a stored function, refer to it in an expression. The function returns a value during expression evaluation.\r\n\r\nCREATE PROCEDURE and CREATE FUNCTION require the CREATE ROUTINE privilege. If the DEFINER clause is present, the privileges required depend on the user value, as discussed in stored-objects-security. If binary logging is enabled, CREATE FUNCTION might require the SUPER privilege, as discussed in stored-programs-logging.\r\n\r\nBy default, MySQL automatically grants the ALTER ROUTINE and EXECUTE privileges to the routine creator. This behavior can be changed by disabling the automatic_sp_privileges system variable. See stored-routines-privileges.\r\n\r\nThe DEFINER and SQL SECURITY clauses specify the security context to be used when checking access privileges at routine execution time, as described later in this section.\r\n\r\nIf the routine name is the same as the name of a built-in SQL function, a syntax error occurs unless you use a space between the name and the following parenthesis when defining the routine or invoking it later. For this reason, avoid using the names of existing SQL functions for your own stored routines.\r\n\r\nThe IGNORE_SPACE SQL mode applies to built-in functions, not to stored routines. It is always permissible to have spaces after a stored routine name, regardless of whether IGNORE_SPACE is enabled.\r\n\r\nThe parameter list enclosed within parentheses must always be present. If there are no parameters, an empty parameter list of () should be used. Parameter names are not case sensitive.\r\n\r\nEach parameter is an IN parameter by default. To specify otherwise for a parameter, use the keyword OUT or INOUT before the parameter name.\r\n\r\nAn IN parameter passes a value into a procedure. The procedure might modify the value, but the modification is not visible to the caller when the procedure returns. An OUT parameter passes a value from the procedure back to the caller. Its initial value is NULL within the procedure, and its value is visible to the caller when the procedure returns. An INOUT parameter is initialized by the caller, can be modified by the procedure, and any change made by the procedure is visible to the caller when the procedure returns.\r\n\r\nFor each OUT or INOUT parameter, pass a user-defined variable in the CALL statement that invokes the procedure so that you can obtain its value when the procedure returns. If you are calling the procedure from within another stored procedure or function, you can also pass a routine parameter or local routine variable as an OUT or INOUT parameter. If you are calling the procedure from within a trigger, you can also pass NEW.col_name as an OUT or INOUT parameter.\r\n\r\nFor information about the effect of unhandled conditions on procedure parameters, see conditions-and-parameters.\r\n\r\nRoutine parameters cannot be referenced in statements prepared within the routine; see stored-program-restrictions.\r\n\r\nThe following example shows a simple stored procedure that uses an OUT parameter:\r\n\r\n>\r\nmysql> delimiter //\r\n\r\nmysql> CREATE PROCEDURE simpleproc (OUT param1 INT)\r\n    -> BEGIN\r\n    ->   SELECT COUNT(*) INTO param1 FROM t;\r\n    -> END//\r\nQuery OK, 0 rows affected (0.00 sec)\r\n\r\nmysql> delimiter ;\r\n\r\nmysql> CALL simpleproc(@a);\r\nQuery OK, 0 rows affected (0.00 sec)\r\n\r\nmysql> SELECT @a;\r\n+------+\r\n| @a   |\r\n+------+\r\n| 3    |\r\n+------+\r\n1 row in set (0.00 sec)\r\nThe example uses the mysql client delimiter command to change the statement delimiter from ; to // while the procedure is being defined. This enables the ; delimiter used in the procedure body to be passed through to the server rather than being interpreted by mysql itself. See stored-programs-defining.\r\n\r\nThe RETURNS clause may be specified only for a FUNCTION, for which it is mandatory. It indicates the return type of the function, and the function body must contain a RETURN value statement. If the RETURN statement returns a value of a different type, the value is coerced to the proper type. For example, if a function specifies an ENUM or SET value in the RETURNS clause, but the RETURN statement returns an integer, the value returned from the function is the string for the corresponding ENUM member of set of SET members.\r\n\r\nThe following example function takes a parameter, performs an operation using an SQL function, and returns the result. In this case, it is unnecessary to use delimiter because the function definition contains no internal ; statement delimiters:\r\n\r\n>\r\nmysql> CREATE FUNCTION hello (s CHAR(20))\r\nmysql> RETURNS CHAR(50) DETERMINISTIC\r\n    -> RETURN CONCAT('Hello, ',s,'!');\r\nQuery OK, 0 rows affected (0.00 sec)\r\n\r\nmysql> SELECT hello('world');\r\n+----------------+\r\n| hello('world') |\r\n+----------------+\r\n| Hello, world!  |\r\n+----------------+\r\n1 row in set (0.00 sec)\r\nParameter types and function return types can be declared to use any valid data type. The COLLATE attribute can be used if preceded by a CHARACTER SET specification.\r\n\r\nThe routine_body consists of a valid SQL routine statement. This can be a simple statement such as SELECT or INSERT, or a compound statement written using BEGIN and END. Compound statements can contain declarations, loops, and other control structure statements. The syntax for these statements is described in sql-compound-statements. In practice, stored functions tend to use compound statements, unless the body consists of a single RETURN statement.\r\n\r\nMySQL permits routines to contain DDL statements, such as CREATE and DROP. MySQL also permits stored procedures (but not stored functions) to contain SQL transaction statements such as COMMIT. Stored functions may not contain statements that perform explicit or implicit commit or rollback. Support for these statements is not required by the SQL standard, which states that each DBMS vendor may decide whether to permit them.\r\n\r\nStatements that return a result set can be used within a stored procedure but not within a stored function. This prohibition includes SELECT statements that do not have an INTO var_list clause and other statements such as SHOW, EXPLAIN, and CHECK TABLE. For statements that can be determined at function definition time to return a result set, a Not allowed to return a result set from a function error occurs (ER_SP_NO_RETSET). For statements that can be determined only at runtime to return a result set, a PROCEDURE %s can't return a result set in the given context error occurs (ER_SP_BADSELECT).\r\n\r\nUSE statements within stored routines are not permitted. When a routine is invoked, an implicit USE db_name is performed (and undone when the routine terminates). The causes the routine to have the given default database while it executes. References to objects in databases other than the routine default database should be qualified with the appropriate database name.\r\n\r\nFor additional information about statements that are not permitted in stored routines, see stored-program-restrictions.\r\n\r\nFor information about invoking stored procedures from within programs written in a language that has a MySQL interface, see call.\r\n\r\nMySQL stores the sql_mode system variable setting in effect when a routine is created or altered, and always executes the routine with this setting in force, regardless of the current server SQL mode when the routine begins executing.\r\n\r\nThe switch from the SQL mode of the invoker to that of the routine occurs after evaluation of arguments and assignment of the resulting values to routine parameters. If you define a routine in strict SQL mode but invoke it in nonstrict mode, assignment of arguments to routine parameters does not take place in strict mode. If you require that expressions passed to a routine be assigned in strict SQL mode, you should invoke the routine with strict mode in effect.\r\n\r\nSee also: : Online help create-procedure";
                    break;
                case "CREATE FUNCTION":
                    generatedText = "";
                    break;
                case "ALTER TABLE":
                    generatedText = "ALTER TABLE Syntax:\r\nALTER TABLE changes the structure of a table. For example, you can add or delete columns, create or destroy indexes, change the type of existing columns, or rename columns or the table itself. You can also change characteristics such as the storage engine used for the table or the table comment.\r\n\r\nTo use ALTER TABLE, you need ALTER, CREATE, and INSERT privileges for the table. Renaming a table requires ALTER and DROP on the old table, ALTER, CREATE, and INSERT on the new table.\r\n\r\n\r\nFollowing the table name, specify the alterations to be made. If none are given, ALTER TABLE does nothing.\r\n\r\n\r\nThe syntax for many of the permissible alterations is similar to clauses of the CREATE TABLE statement. column_definition clauses use the same syntax for ADD and CHANGE as for CREATE TABLE. For more information, see create-table.\r\n\r\n\r\nThe word COLUMN is optional and can be omitted, except for RENAME COLUMN (to distinguish a column-renaming operation from the RENAME table-renaming operation).\r\n\r\n\r\nMultiple ADD, ALTER, DROP, and CHANGE clauses are permitted in a single ALTER TABLE statement, separated by commas. This is a MySQL extension to standard SQL, which permits only one of each clause per ALTER TABLE statement. For example, to drop multiple columns in a single statement, do this:\r\n\r\n>\r\nALTER TABLE t2 DROP COLUMN c, DROP COLUMN d;\r\n\r\nIf a storage engine does not support an attempted ALTER TABLE operation, a warning may result. Such warnings can be displayed with SHOW WARNINGS. See show-warnings. For information on troubleshooting ALTER TABLE, see alter-table-problems.\r\n\r\n\r\nFor information about generated columns, see alter-table-generated-columns.\r\n\r\n\r\nFor usage examples, see alter-table-examples.\r\n\r\n\r\nInnoDB in MySQL 8.0.17 and later supports addition of multi-valued indexes on JSON columns using a key_part specification can take the form (CAST json_path AS type ARRAY). See create-index-multi-valued, for detailed information regarding multi-valued index creation and usage of, as well as restrictions and limitations on multi-valued indexes.\r\n\r\n\r\nWith the mysql_info() C API function, you can find out how many rows were copied by ALTER TABLE. See mysql-info.\r\n\r\n\r\n\r\nSee also: : Online help alter-table";
                    break;
                // Agrega más casos según los elementos de tu ComboBox
                default:
                    generatedText = "Automatic context help is disabled. Use the toolbar to manually get help for the current caret position or to toggle automatic help.";
                    break;
            }

            textBox1.Text = generatedText;
        }
    }
}
