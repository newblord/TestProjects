var React = require('react');
var ReactDOM = require('react-dom');

class Test extends React.Component {
    render() {
        return (
            <div>
                <h1>Test</h1>
            </div>
        );
    }
}


ReactDOM.render(
    <Test />,
    document.getElementById('main')
  );