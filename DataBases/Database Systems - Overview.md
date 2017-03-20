**Answer following
questions in Markdown format (****.md**** file)**

1. What database models do you know?

-     
Hierarchical

-     
Relational

-     
Network

-     
Object-oriented

2. Which are the main functions performed by a Relational
     Database Management System (RDBMS)?

-     
They store data in
tables, which are related. They create, remove or change the data, tables or
the relations between them.

3. Define what is "table" in database terms.

-     
Tables contain data,
arranged in rows and columns.

-     
All rows have the same
structure.

-     
The columns have name
and type.

4. Explain the difference between a primary and a foreign
     key.

-     
The primary key
defines each separate row of a table. The elements of the table are different
only if their ID (primary key) is different. It is usually an integer.

-     
The foreign key is the
relation between a record in the table with records in other tables (it is,
usually, primary key in other tables).

5. Explain the different kinds of relationships between
     tables in relational databases.

-     
One-to-many – one record
from a table may be related to many records in another table.

-     
Many-to-many – many records
from a table may be related to many records in another table.

-     
One-to-one – one record
from a table may be related to only one record in another table.

(There is also a possibility of one-to-zero –
a record may or may not be related to a record in another table. Records may
also be related to another records in their own table).

6. When is a certain database schema normalized?
    - What are the advantages of normalized databases?

-     
Database schema is
normalized when data duplications are removed. Immediate result of that is that
the tables become smaller. IDs have smaller range, which makes searching and
sorting records, as well as creating indexes faster.

7. What are database integrity constraints and when are
     they used?

-     
Integrity constraints
ensure that rules are followed when recording data in a table. It ensures the integrity
if the data in a table, for example – that a row has only unique IDs, or that
data meets some predefined criteria (e.g. – is string with a pre-defined max
length).

8. Point out the pros and cons of using indexes in a
     database.

-     
They make SELECT
query, for example, quicker, they are also often used for relating records between
tables (it is better with ID then with entire strings, for example, because
working with them is quicker – though it always depends on the circumstances).
On the other hand, they also need HDD memory and RAM.

9. What's the main purpose of the SQL language?

-     
Structured Query
Language – it is used for creating, selecting, altering or removing data from RDBMS.

10. What are transactions used for?
    - Give an example.

-     
Transactions are
series of database operations. They are executed consecutively and as a single
operation. Either all of them are performed, or none – this is useful in cases
of failure, when the status of some operations may be unclear and errors in the
database may occur. The most famous example is with bank operations. A
transaction in this case ensures that, when the money is removed from one
account, it is added to the other. Also – that the removed and added amounts
are the same. That another transaction won’t intervene in the middle of the
process (which could create errors in the data) and that the action won’t be
undone only for one of the accounts (a transaction can be rolled-back, it is
another case).

11. What is a NoSQL database?

-     
Not Only Structured
Query Language – it is modeled in а concerted means, other than the tabular
relations from the relational databases.

12. Explain the classical non-relational data models.

-     
Key-value (like
dictionary or hashtable)

-     
Wide column store –
uses tables, rows and columns, but the rows may not have the same structure.

-     
Object model –
OOP-style objects

-     
Graph – its elements
are related with a finite number of relations between them.

13. Give few examples of NoSQL databases and their pros and
     cons.

-     
Redis – supports abstract

-     
MongoDB – structured information
in JSON.

-     
Cassandra –
scalability.

 