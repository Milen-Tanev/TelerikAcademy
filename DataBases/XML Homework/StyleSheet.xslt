<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
            xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
            xmlns:students="urn:students"
            xmlns:taken_exams="urn:exams"
>
  <xsl:template match="/">
    <html>
      <body>
        <h2>Students</h2>
        <table border="1">
          <tr bgcolor="#aaff55">
            <th style="text-align:left">Name</th>
            <th style="text-align:left">Faculty Number</th>
            <th style="text-align:left">Taken exams</th>
          </tr>
          <xsl:for-each select="/students:students/students:student">
            <tr>
              <td>
                <xsl:value-of select="students:name"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="students:faculty_number"></xsl:value-of>
              </td>
              <td>
                <xsl:for-each select="students:taken_exams/taken_exams:exam">
                  <br>
                    <xsl:value-of select="taken_exams:name"></xsl:value-of> - <xsl:value-of select="taken_exams:score"></xsl:value-of>
                  </br>
                </xsl:for-each>                  
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>