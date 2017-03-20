<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
            xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="html"/>
  <xsl:template match="/">
    <html>
      <body>
        <h2>Music Catalog</h2>
        <table border="1">
          <tr bgcolor="#aaff55">
            <th style="text-align:left">Name</th>
            <th style="text-align:left">Artist</th>
            <th style="text-align:left">Year</th>
            <th style="text-align:left">Producer</th>
            <th style="text-align:left">Price</th>
            <th style="text-align:left">Track list</th>
          </tr>
          <xsl:for-each select="/catalogue/album">
            <tr>
              <td>
                <xsl:value-of select="name"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="artist"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="year"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="producer"></xsl:value-of>
              </td>
              <td>
                <xsl:value-of select="price"></xsl:value-of>
              </td>
              <td>
                <xsl:for-each select="songlist/song">
                  <xsl:value-of select="title"></xsl:value-of> - <xsl:value-of select="duration"></xsl:value-of>
                  <br></br>
                </xsl:for-each>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>