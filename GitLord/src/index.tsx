import * as React from 'react';
import * as ReactDom from 'react-dom';

class App extends React.Component<any, any> {
    render()
    {
        return <h1>Hello World!</h1>;
    }
}

ReactDom.render( 
    <App />,
    document.getElementById("main")
);