const http = require('http')
const fs = require('fs')
const path = require('path')

function getContentType (pathname) {
  let contentTypes = {
    '.ico': 'image/x-icon',
    '.png': 'image/png',
    '.css': 'text/css',
    '.js': 'application/javascript'
  }

  let extension = path.extname(pathname)

  return contentTypes[extension]
}

/**
 * @param {http.ClientRequest} req
 * @param {http.ServerResponse} res
 */
module.exports = (req, res) => {
  if (req.pathname.startsWith('/public/') && req.method === 'GET') {
    res.writeHead(200, { 'Content-Type': getContentType(req.pathname) })

    fs.createReadStream('.' + req.pathname)
      .on('error', err => {
        console.log(err)
        return false
      })
      .pipe(res)
  }
}
