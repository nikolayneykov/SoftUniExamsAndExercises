const http = require('http')
const fs = require('fs')
const homePath = './views/home.html'

/**
 * @param {http.ClientRequest} req
 * @param {http.ServerResponse} res
 */
module.exports = (req, res) => {
  if (req.pathname === '/' && req.method === 'GET') {
    res.writeHead(200, { 'Content-Type': 'text/html' })

    fs.createReadStream(homePath)
      .on('error', err => {
        console.log(err)
        return false
      })
      .pipe(res)
  } else {
    return true
  }
}
