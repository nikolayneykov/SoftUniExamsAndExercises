/* global $ */
function getBugTracker () {
  let [reportList, count, selector] = [[], 0, null]

  function output (selectorParam) {
    selector = selectorParam
  }

  function setStatus (id, newStatus) {
    reportList.find(r => r.ID === id).status = newStatus
    displayBugReport()
  }

  function remove (id) {
    reportList = reportList.filter(r => r.ID !== id)
    displayBugReport()
  }

  function sort (method) {
    reportList.sort((a, b) =>
      method === 'author'
        ? a[method].localeCompare(b[method])
        : a[method] - b[method]
    )
    displayBugReport()
  }

  function report (author, description, reproducible, severity) {
    reportList.push({
      ID: count++,
      author,
      description,
      reproducible,
      severity,
      status: 'Open'
    })
    displayBugReport()
  }

  function displayBugReport () {
    let container = $(selector).empty()

    reportList.forEach(r => {
      container.append(
        $('<div>')
          .attr('id', `report_${r.ID}`)
          .addClass('report')
          .append(
            $('<div>')
              .addClass('body')
              .append($('<p>').text(r.description))
          )
          .append(
            $('<div>')
              .addClass('title')
              .append(
                $('<span>')
                  .addClass('author')
                  .text(`Submited by: ${r.author}`)
              )
              .append(
                $('<span>')
                  .addClass('status')
                  .text(`${r.status} | ${r.severity}`)
              )
          )
      )
    })
  }

  return { output, setStatus, remove, sort, report }
}
