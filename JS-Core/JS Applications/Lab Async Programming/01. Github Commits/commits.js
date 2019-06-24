/* global $ */

function loadCommits () {
  let username = $('#username').val()
  let repo = $('#repo').val()
  let baseUrl = 'https://api.github.com/repos'

  $.ajax({
    method: 'GET',
    url: `${baseUrl}/${username}/${repo}/commits`
  })
    .then(commits => {
      commits.forEach(data => {
        console.log(data)
        $('#commits')
          .append($('<li>')
            .text(`${data.commit.author.name}: ${data.commit.message}`))
      })
    })
    .catch(err => {
      $('#commits')
        .append($('<li>')
          .text(`Error: ${err.status} (${err.statusText})`))
    })
}
