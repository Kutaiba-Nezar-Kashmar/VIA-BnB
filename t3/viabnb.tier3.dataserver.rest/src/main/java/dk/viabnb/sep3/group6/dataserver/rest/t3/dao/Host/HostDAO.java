package dk.viabnb.sep3.group6.dataserver.rest.t3.dao.Host;

import dk.viabnb.sep3.group6.dataserver.rest.t3.models.Host;

import java.util.List;

public interface HostDAO {

    Host RegisterHost(Host host);
    Host getHostByEmail(String email);
    Host getHostById(int Id);
    List<Host> getAllHosts();
    List<Host> getAllNotApprovedHosts();
    Host approveHost(Host host);
    Host rejectHost(Host host);

}
