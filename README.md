# Note

This repo was started 2022-06-25 and is not finished.

# Application Description

- Documentation for Blazor that makes use of a Blazor REPL.

A quick example of what the idea is would be the recreation of React documentation currently found at:

> https://beta.reactjs.org/learn

The following video goes over the details of the React documentation rewrite

> https://www.youtube.com/watch?v=Kbb9oOhoRkM

- Users can save examples of Blazor code and share it with others.

A quick example of what the idea is would be the Svelte UI Framework's REPL currently found at:

> https://svelte.dev/repl/

# Link to the Azure website host

> https://blazor-docs-interactive.azurewebsites.net/

- Note: the application is webassembly and one can clear the site cache if they find they're running an older version.

- Note: the application is a PWA and one can download the website to run it locally as a application on their operating system.

- Note: a goal is to allow a user to download any examples that other users create in the Blazor REPL. This allows offline usage of the website when downloaded as a PWA and the cached version would be used without the internet needed.

- Note: the entirety of the documentation on Blazor is to have alongside it an interactive editor that one can change and run the code for.

- Note: as this is a PWA website one should be able to run it offline without internet. If they have internet they can make use of various API calls that will be made available.
    - For example, a 'save' button for a user's REPL session.
    - A 'share' button for the user's REPL session.
    - A 'browse' section for other users' published REPL sessions.