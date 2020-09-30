Feature: Check if the headline article name matches the required title

@mytag

Scenario: Check if the headline article name matches the required title
Given Opened News tab
When Get text from the headline article
Then The name of the article should be equal to the specific text

