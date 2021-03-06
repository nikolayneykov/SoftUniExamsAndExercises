const fs = require('fs')
let storage = {}

function validateKeyAsString (key) {
  if (typeof key !== 'string') {
    throw new TypeError('The key must be string!')
  }

  return true
}

function validateExistingKey (key, action) {
  if (storage.hasOwnProperty(key) && action === 'put') {
    throw new TypeError('The key already exists in the storage!')
  } else if (
    !storage.hasOwnProperty(key) &&
    (action === 'get' || action === 'update' || action === 'remove')
  ) {
    throw new TypeError('The key does not exist in the storage!')
  }

  return true
}

function put (key, value) {
  if (validateKeyAsString(key) && validateExistingKey(key, 'put')) {
    storage[key] = value
  }
}

function get (key) {
  if (validateKeyAsString(key) && validateExistingKey(key, 'get')) {
    return storage[key]
  }
}

function getAll () {
  return Object.keys(storage).length === 0
    ? 'There are no items in the storage'
    : storage
}

function update (key, value) {
  if (validateKeyAsString(key) && validateExistingKey(key, 'update')) {
    storage[key] = value
  }
}

function remove (key) {
  if (validateKeyAsString(key) && validateExistingKey(key, 'remove')) {
    delete storage[key]
  }
}

function clear () {
  storage = {}
}

function save () {
  fs.writeFileSync('./storage.json', JSON.stringify(storage))
}

function load () {
  if (fs.existsSync('./storage.json')) {
    storage = JSON.parse(fs.readFileSync('./storage.json'))
  }
}

module.exports = { put, get, getAll, update, delete: remove, clear, save, load }
