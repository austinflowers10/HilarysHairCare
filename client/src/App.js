import './App.css';
import { Navbar, NavbarBrand, Nav, NavItem, NavLink } from "reactstrap";
import "bootstrap/dist/css/bootstrap.css";
import { Outlet } from "react-router-dom";

function App() {
    return <>
        <Navbar color="info" expand="md">
            <Nav navbar>
                <NavbarBrand href="/">Hilary's Hair Care</NavbarBrand>
                <NavItem>
                    <NavLink href="/stylists">Stylists</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink href="/customers">Customers</NavLink>
                </NavItem>
                <NavItem>
                    <NavLink href="/services">Services</NavLink>
                </NavItem>
            </Nav>
        </Navbar>
        <Outlet />
    </>
  
}

export default App;
