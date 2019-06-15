/* global $ */

function loadRepos () {
  let repos = $('#repos')
  let url = `https://api.github.com/users/${$('#username').val()}/repos`
  $.ajax({
    method: 'GET',
    url,
    success: data => {
      repos.empty()
      data.forEach(repo => {
        $('<li>')
          .append($('<a>').attr('href', repo.html_url).text(repo.full_name))
          .appendTo(repos)
      })
    },
    error: err => {
      console.log(err)
      repos.empty()
      repos.append($(`<li>Error</li>`))
    }
  })
}
