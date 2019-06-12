function validateRequest (request) {
  const validMethods = ['GET', 'POST', 'DELETE', 'CONNECT']
  const validVersions = ['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0']
  const validUriPattern = /^[\w.]+$/
  const validMessagePattern = /^$|^[^<>\\&'"]+$/

  if (!validMethods.includes(request.method)) {
    throw new Error('Invalid request header: Invalid Method')
  } else if (!request.uri || !validUriPattern.test(request.uri)) {
    throw new Error('Invalid request header: Invalid URI')
  } else if (!validVersions.includes(request.version)) {
    throw new Error('Invalid request header: Invalid Version')
  } else if (
    request.message === undefined ||
    !validMessagePattern.test(request.message)
  ) {
    throw new Error('Invalid request header: Invalid Message')
  }

  return request
}

console.log(
  validateRequest({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    message: ''
  })
)
