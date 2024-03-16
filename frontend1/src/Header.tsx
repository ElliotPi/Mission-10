import logo from './logo.png';

// The Header component for the site
function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-12">
        <img
          src={logo}
          className="logo"
          alt="a guy bowling"
          width="900"
          height="550"
        />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">Welcome to Ultimate Bowling Club!</h1>
      </div>
    </header>
  );
}

export default Header;
