const http = require('http')
const fs = require('fs')
const qs = require('querystring')
const db = require('../config/dataBase')
const url = require('url')

/**
 * @param {http.ClientRequest} req
 * @param {http.ServerResponse} res
 */
module.exports = (req, res) => {
  if (req.pathname === '/viewAllMovies' && req.method === 'GET') {
    getAllMovies(req, res)
  } else if (req.pathname === '/details' && req.method === 'GET') {
    getMovieDetails(req, res)
  } else if (req.pathname === '/addMovie' && req.method === 'GET') {
    getAddMovieForm(req, res)
  } else if (req.pathname === '/addMovie' && req.method === 'POST') {
    addMovie(req, res)
  } else {
    return true
  }
}

function getAllMovies (req, res) {
  let movies = db
    .map(
      m => `<div class="movie">              
              <a href="/details?id=${m.id}">
                <img class="moviePoster" src="${m.moviePoster}"/>
              </a>   
              <h3>${m.movieTitle} (${m.movieYear})</h3>          
            </div>`
    )
    .join('')

  let body = ''
  let readStream = fs.createReadStream('./views/viewAll.html')

  readStream
    .on('data', data => (body += data))
    .on('error', handleError)
    .on('end', () => {
      let html = body
        .toString()
        .replace('<div id="replaceMe">{{replaceMe}}</div>', movies)
      res.write(html)
      res.end()
    })
}

function getMovieDetails (req, res) {
  let id = +qs.parse(url.parse(req.url).query).id
  let movieData = db.find(m => m.id === id)
  let body = ''

  fs.createReadStream('./views/details.html')
    .on('data', data => (body += data))
    .on('error', handleError)
    .on('end', () => {
      let movie = body.replace(
        '<div id="replaceMe">{{replaceMe}}</div>',
        `<div class="content">
         <img src="${movieData.moviePoster}" alt="" />
         <h3>Title ${movieData.movieTitle}</h3>
         <h3>Year ${movieData.movieYear}</h3>
         <p>${movieData.movieDescription}</p>
       </div>`
      )

      res.writeHead(200, { 'Content-Type': 'text/html' })
      res.write(movie)
      res.end()
    })
}

function getAddMovieForm (req, res) {
  res.writeHead(200, { 'Content-Type': 'text/html' })

  fs.createReadStream('./views/addMovie.html')
    .on('error', handleError)
    .pipe(res)
}

function addMovie (req, res) {
  let body = ''

  req
    .on('data', data => (body += data))
    .on('error', handleError)
    .on('end', () => {
      res.writeHead(302, { Location: '/viewAllMovies' })
      let movie = qs.parse(body)
      movie.id = db.length + 1

      if (Object.values(movie).every(v => v !== '')) {
        db.push(movie)
      }

      res.end()
    })
}

function handleError (err) {
  console.log(err)
  return false
}
