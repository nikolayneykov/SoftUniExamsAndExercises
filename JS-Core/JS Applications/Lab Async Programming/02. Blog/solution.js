/* global $ btoa */

function attachEvents () {
  const baseUrl = 'https://baas.kinvey.com/appdata/kid_S1Pec4CJS'
  const authHeaders = { 'Authorization': `Basic ${btoa('guest:guest')}` }

  $('#btnLoadPosts').click(loadPosts)
  $('#btnViewPost').click(viewPost)

  async function loadPosts () {
    let posts = await $.get({
      url: `${baseUrl}/posts`,
      headers: authHeaders
    })

    $('#posts').empty()

    posts.forEach(p => {
      $('#posts')
        .append($('<option>')
          .val(p._id)
          .text(p.title))
    })
  }

  async function viewPost () {
    let post = await $.get({
      url: `${baseUrl}/posts/${$('#posts').val()}`,
      headers: authHeaders
    })

    $('#post-title').text(post.title)
    $('#post-body').text(post.body)

    let comments = await $.get({
      url: `${baseUrl}/comments/?query={"post_id":"${post._id}"}`,
      headers: authHeaders
    })

    $('#post-comments').empty()

    comments.forEach(c => {
      $('#post-comments')
        .append($('<li>').text(c.text))
    })
  }
}
