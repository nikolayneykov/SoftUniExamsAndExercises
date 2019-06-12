/* global $ */
function solve (selector) {
  let children = $(selector)
    .addClass('highlight')
    .children()

  while (children.children().length) {
    children = children.children()
  }

  children
    .first()
    .addClass('highlight')
    .parentsUntil($(selector))
    .addClass('highlight')
}
